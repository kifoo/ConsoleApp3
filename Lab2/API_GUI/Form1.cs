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
            GetCharacterDB();
            if(characterDB.Count == 0)
            {
                searchInfoLabel.Visible = true;
                local = false;
                SearchAPI();
            }
            else
            {
                local = true;
            }
            CharacterAction();
            searchInfoLabel.Visible = false;
        }
        /* Search for result through local database */
        private void GetCharacterDB()
        {
            try
            {
                var query = db.Character.AsQueryable();

                if (!string.IsNullOrEmpty(character_box.Text))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error: Could not connect to the database");
            }
            
        }
        /* Search for result through API */
        private async void SearchAPI()
        {
            try
            {
                string response = await client.GetStringAsync(GetCharacterURL());
                character_API = JsonConvert.DeserializeObject<Character>(response);
                if(character_API.results.Count == 0) { return; }
                while (character_API.info.next != null)
                {
                    response = await client.GetStringAsync(character_API.info.next);
                    Character nextPage = JsonConvert.DeserializeObject<Character>(response);
                    character_API.results.AddRange(nextPage.results);
                    character_API.info.next = nextPage.info.next;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error: Could not connect to the API");
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
            CreateCharacterList();
            character_description.Visible = true;
            picture_box.SizeMode = PictureBoxSizeMode.Zoom;
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
        /* Create list of characters that meets the given requirements  */
        private async void CreateCharacterList()
        {
            if (local)
            {
                character_list.DisplayMember = "Name";
                character_list.DataSource = characterDB;
            }
            else
            {
                try
                {
                    if (character_API.results.Count != 0)
                    {
                        foreach (Result result in character_API.results)
                        {
                            Result_DB res = new()
                            {
                                id = result.id,
                                name = result.name,
                                status = result.status.ToString(),
                                species = result.species,
                                type = result.type,
                                gender = result.gender.ToString(),
                                origin = result.origin.name,
                                location = result.location.name,
                                image = result.image,
                                episode = result.episode,
                                url = result.url,
                                created = result.created,
                            };
                            if (db.Character.Any(c => c.id != res.id))
                            {
                                await db.Character.AddAsync(res);
                                await db.SaveChangesAsync();
                            }
                        }
                        db.SaveChanges();
                    }
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
                character_list.DisplayMember = "Name";
                character_list.DataSource = character_API.results;
            }
        }
        /* Display selected character description and image */
        private void Character_list_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
