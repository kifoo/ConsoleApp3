using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using System.Net;
using API_GUI.Elements;
using API_GUI.Enums;
using static API_GUI.Elements.Characters;
using System.Windows.Forms;
using System.Security.Policy;
using System.Linq;
using static API_GUI.Characters_DB;
using System.Data.Common;

namespace API_GUI
{
    public partial class Form1 : Form
    {
        Character character_API;
        private string base_url = "https://rickandmortyapi.com/api/";
        private HttpClient client;

        private bool local = true;
        private CharactersDataBase db;
        List<Result_DB> characterDB;

        public Form1()
        {
            InitializeComponent();
            db = new CharactersDataBase();
            client = new HttpClient();

            // Get the Gender enum values
            Array genderValues = Enum.GetValues(typeof(Gender));
            // Add the Gender enum values to the ComboBox
            foreach (Gender gender in genderValues)
            {
                gender_box.Items.Add(gender);
            }

            // Get the Status enum values
            Array statusValues = Enum.GetValues(typeof(Status));
            // Add the Status enum values to the ComboBox
            foreach (Status status in statusValues)
            {
                status_box.Items.Add(status);
            }
        }
        /* Search button action */
        private void characterButtonClick(object sender, EventArgs e)
        {
            if (local == true)
            {
                GetCharacterDB();
                CharacterAction();
            }
            else
            {
                SearchAPI();
            }
        }
        /* Search for result through local database */
        private void GetCharacterDB()
        {
            var query = db.Character.AsQueryable();
            
            if ( !string.IsNullOrEmpty(character_box.Text))
            {
                query = query.Where(c => c.name.Contains(character_box.Text));
            }
            if (status_box.SelectedItem != null)
            {
                Status selectedStatus = (Status)status_box.SelectedItem;
                query = query.Where(c => c.status.Contains(selectedStatus.ToString()));
            }
            if (!string.IsNullOrEmpty(species_box.Text))
            {
                query = query.Where(c => c.species.Contains(species_box.Text));
            }
            if (!string.IsNullOrEmpty(type_box.Text))
            {
                query = query.Where(c => c.type.Contains(type_box.Text));
            }
            if (gender_box.SelectedItem != null)
            {
                Gender selectedGender = (Gender)gender_box.SelectedItem;
                query = query.Where(c => c.gender.Contains(selectedGender.ToString()));
            }
            characterDB = query.ToList();
        }
        /* Search for result through API */
        private async void SearchAPI()
        {
            try
            {
                string response = await client.GetStringAsync(GetCharacterURL());
                if (response == null) { return; }
                character_API = JsonConvert.DeserializeObject<Character>(response);
                next_button.Visible = (character_API.info.next != null);
                CharacterAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /* Create URL for the API search */
        private string GetCharacterURL()
        {
            string url = base_url + $"character/?";
            if (character_box.Text != "" && character_box.Text != null)
            {
                url += $"&name={character_box.Text}";
            }
            if (status_box.SelectedItem != null)
            {
                Status selectedStatus = (Status)status_box.SelectedItem;
                url += $"&status={selectedStatus}";
            }
            if (species_box.Text != "" && species_box.Text != null)
            {
                url += $"&species={species_box.Text}";
            }
            if (type_box.Text != "" && type_box.Text != null)
            {
                url += $"&type={type_box.Text}";
            }
            if (gender_box.SelectedItem != null)
            {
                Gender selectedGender = (Gender)gender_box.SelectedItem;
                url += $"&gender={selectedGender}";
            }
            return url;
        }
        /* Display description and image of first element in the list */
        private void CharacterAction()
        {
            character_description.Visible = true;
            picture_box.SizeMode = PictureBoxSizeMode.Zoom;
            CreateCharacterList();
            if (local)
            {
                character_description.Text = characterDB[0].ToString();
                picture_box.Load(characterDB[0].image);
            }
            else
            {
                character_description.Text = character_API.results[0].ToString();
                picture_box.Load(character_API.results[0].image);
            }
        }
        /* Create Result_DB from Result */
        private Result_DB API_to_DB(Result result) 
        {
            Result_DB res = new Result_DB();
            res.id = result.id;
            res.name = result.name;
            res.status = result.status;
            res.species = result.species;
            res.type = result.type;
            res.gender = result.gender;
            res.origin = result.origin.name;
            res.location = result.location.name;
            res.image = result.image;
            res.episode = result.episode;
            res.url = result.url;
            res.created = result.created;
            return res;
             
        }   
        /* Create list of characters that meets the given requirements  */
        private async void CreateCharacterList()
        {
            if (local)
            {
                character_list.DataSource = characterDB;
                character_list.DisplayMember = "Name";
            }
            else
            {
                try
                {
                    foreach (Result result in character_API.results)
                    {
                        Result_DB res = API_to_DB(result);
                        if( db.Character.Count() <= 0)
                        {
                            await db.Character.AddAsync(res);
                            await db.SaveChangesAsync();
                        }
                        else if ( db.Character.Any(c => c.id != res.id))
                        {
                            await db.Character.AddAsync(res);
                            await db.SaveChangesAsync();
                        }
                    }
                    db.SaveChanges();
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                {
                    // Examine the inner exception
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                    }
                    else
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                character_list.DataSource = character_API.results;
                character_list.DisplayMember = "Name";
            }
        }
        
        /* API search for next page characters */
        private async void NextPageButtonClick(object sender, EventArgs e)
        {
            string nextPageItems = await client.GetStringAsync(character_API.info.next);
            character_API = JsonConvert.DeserializeObject<Character>(nextPageItems);

            next_button.Visible = (character_API.info.next != null);
            previous_button.Visible = (character_API.info.prev != null);
            
            CreateCharacterList();
        }
        /* API search for previous page characters */
        private async void PrevPageButtonClick(object sender, EventArgs e)
        {
            string nextPageItems = await client.GetStringAsync((string?)character_API.info.prev);
            character_API = JsonConvert.DeserializeObject<Character>(nextPageItems);

            next_button.Visible = (character_API.info.next != null);
            previous_button.Visible = (character_API.info.prev != null);

            CreateCharacterList();
        }

        /* Display description and image of selected character */
        private void character_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (local)
            {
                Result_DB selectedResult = (Result_DB)character_list.SelectedItem;
                character_description.Text = selectedResult?.ToString();
                picture_box.Load(selectedResult?.image);
            }
            else
            {
                Result selectedResult = (Result)character_list.SelectedItem;
                character_description.Text = selectedResult?.ToString();
                picture_box.Load(selectedResult?.image);
            }            
        }
        /* Selection of search type */
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                if (radioButton == RB_internet)
                {
                    RB_local.Checked = false;
                    local = false;
                    // Internet search is selected
                }
                else if (radioButton == RB_local)
                {
                    RB_internet.Checked = false;
                    local = true;
                    // Local search is selected
                }
            }
        }
    }
}
