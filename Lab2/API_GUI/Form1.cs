using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Security.Policy;
using System.Linq;
using API_GUI.API;
using API_GUI.Enums;
using static API_GUI.API.Characters;
using API_GUI.DataBase;
using static API_GUI.DataBase.Characters_DB;
using System.Data.Common;

namespace API_GUI
{
    public partial class Form1 : Form
    {
        private const string errorMessage = $"{{\"error\":\"There is nothing here\"}}";
        Character character_API;
        private string base_url = "https://rickandmortyapi.com/api/";
        private HttpClient client;

        private bool local = true;
        private CharactersDataBase db;
        List<Result_DB> characterDB;
        string url = "";

        public Form1()
        {
            InitializeComponent();
            character_API = new Character();
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
        private async void characterButtonClick(object sender, EventArgs e)
        {
            try
            {
                moreCharactersAPI.Visible = false;
                searchInfoLabel.Visible = false;
                url = GetCharacter();
                local = true;
                if (characterDB == null || characterDB.Count == 0)
                {
                    searchInfoLabel.Visible = true;
                    local = false;
                    bool success = await SearchAPI(url);
                    if (success)
                    {
                        CharacterAction();
                    }
                }
                else
                {
                    local = true;
                    CharacterAction();
                    moreCharactersAPI.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\ncharacterButtonClick");
            }
        }
        /* Search for result through local database and create a url if needed */
        private string GetCharacter()
        {
            try
            {
                var query = db.Character.AsQueryable();
                url = base_url + $"character/?";

                if (!string.IsNullOrEmpty(character_box.Text))
                {
                    query = query.Where(c => c.name.Contains(character_box.Text));
                    url += $"&name={character_box.Text}";
                }
                if (status_box.SelectedItem != null)
                {
                    Status selectedStatus = (Status)status_box.SelectedItem;
                    query = query.Where(c => c.status.Contains(selectedStatus.ToString()));
                    url += $"&status={selectedStatus}";
                }
                if (!string.IsNullOrEmpty(species_box.Text))
                {
                    query = query.Where(c => c.species.Contains(species_box.Text));
                    url += $"&species={species_box.Text}";
                }
                if (!string.IsNullOrEmpty(type_box.Text))
                {
                    query = query.Where(c => c.type.Contains(type_box.Text));
                    url += $"&type={type_box.Text}";
                }
                if (gender_box.SelectedItem != null)
                {
                    Gender selectedGender = (Gender)gender_box.SelectedItem;
                    query = query.Where(c => c.gender.Contains(selectedGender.ToString()));
                    url += $"&gender={selectedGender}";
                }
                characterDB = query.ToList();

                return url;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nGetCharacterDB");
                return url;
            }
            
        }
        /* Search for result through API */
        private async Task<bool> SearchAPI(string url)
        {
            try
            {
                string response = await client.GetStringAsync(url);
                if (response == errorMessage)
                {
                    MessageBox.Show("No items found.");
                    return false;
                }
                character_API = JsonConvert.DeserializeObject<Character>(response);
                while (character_API.info.next != null)
                {
                    response = await client.GetStringAsync(character_API.info.next);
                    Character nextPage = JsonConvert.DeserializeObject<Character>(response);
                    character_API.results.AddRange(nextPage.results);
                    character_API.info.next = nextPage.info.next;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nNo items found.\n\nSearchAPI");
                return false;
            }
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
        private void CreateCharacterList()
        {
            if (local)
            {
                character_list.DisplayMember = "Name";
                character_list.DataSource = characterDB;
                CharacterCount.Visible = true;
                CharacterCount.Text = $"Found {characterDB.Count} maching characters.";
            }
            else
            {
                if (true)
                {
                    try
                    {

                        foreach (Result result in character_API.results)
                        {
                            if (!db.Character.Any(c => c.id == result.id))
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
                                db.Character.Add(res);
                                db.SaveChanges();
                            }
                        }
                        db.SaveChanges();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nCreateCharacterList");
                    }
                    character_list.DisplayMember = "Name";
                    character_list.DataSource = character_API.results;
                    CharacterCount.Visible = true;
                    CharacterCount.Text = $"Found {character_API.results.Count} maching characters.";
                }
            }
        }
        /* Display selected character description and image */
        private void Character_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (local)
            {
                Result_DB? selectedResult = character_list.SelectedItem as Result_DB;
                character_description.Text = selectedResult?.ToString();
                picture_box.Load(selectedResult?.image);
            }
            else
            {
                Result? selectedResult = character_list.SelectedItem as Result;
                character_description.Text = selectedResult?.ToString();
                picture_box.Load(selectedResult?.image);
            }            
        }
        /* API Search */
        private async void searchAPIButton_Click(object sender, EventArgs e)
        {
            try
            {
                local = false;
                bool success = await SearchAPI(url);
                if (success)
                {
                    CharacterAction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nsearchAPIButton_Click");
            }
        }
    }
}
