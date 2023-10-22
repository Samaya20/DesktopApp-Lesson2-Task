using System.Text.Json;

namespace Excel_Load
{

    public partial class Form1 : Form
    {
        private List<Person> peopleList;
        public Form1()
        {
            InitializeComponent();
            LoadPeopleData();
        }

        private void LoadPeopleData()
        {
            peopleList = new List<Person>();

            if (File.Exists("people.json"))
            {
                string jsonData = File.ReadAllText("people.json");
                if (!string.IsNullOrEmpty(jsonData))
                {
                    peopleList = JsonSerializer.Deserialize<List<Person>>(jsonData);
                }
            }
        }

        private void SavePeopleData()
        {
            string jsonData = JsonSerializer.Serialize(peopleList);
            File.WriteAllText("people.json", jsonData);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string targetName = nameInput.Text;
            if (peopleList.Any(p => p.Name == targetName))
            {
                MessageBox.Show("Bu məlumatlara sahib şəxs qeydiyyatda var!");
            }
            else
            {
                Person person = new Person
                {
                    Name = nameInput.Text,
                    Surname = surnameInput.Text,
                    FatherName = fathernameInput.Text,
                    Country = countryInput.Text,
                    City = cityInput.Text,
                    Number = numberInput.Text,
                    BirthDate = dateTimePicker1.Value,
                    Gender = radioButtonFemale.Checked ? "Qadın" : "Kişi"
                };

                peopleList.Add(person);

                SavePeopleData();

                nameInput.Clear();
                surnameInput.Clear();
                fathernameInput.Clear();
                countryInput.Clear();
                cityInput.Clear();
                numberInput.Clear();
                dateTimePicker1.Value = DateTime.Now;
                radioButtonFemale.Checked = false;
                radioButtonMale.Checked = false;
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string targetName = loadInput.Text;
            Person targetPerson = peopleList.FirstOrDefault(p => p.Name == targetName);

            if (targetPerson != null)
            {
                nameInput.Text = targetPerson.Name;
                surnameInput.Text = targetPerson.Surname;
                fathernameInput.Text = targetPerson.FatherName;
                countryInput.Text = targetPerson.Country;
                cityInput.Text = targetPerson.City;
                numberInput.Text = targetPerson.Number;
                dateTimePicker1.Value = targetPerson.BirthDate;

                if (targetPerson.Gender == "Qadın")
                {
                    radioButtonFemale.Checked = true;
                }
                else if (targetPerson.Gender == "Kişi")
                {
                    radioButtonMale.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bu ada sahib şəxs qeydiyyatda yoxdur!");
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string FatherName { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Number { get; set; }
            public DateTime BirthDate { get; set; }
            public string Gender { get; set; }
        }
    }
}