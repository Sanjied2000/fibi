using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Fibi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Birthday();
           
        }
        private void SetProfileImage(int age, string gender)
        {
            string imageName = "";

            int imageNumber = (age / 12) + 1;

            if (gender == "Male")
            {
                if (imageNumber >= 1 && imageNumber <= 5)
                {
                    imageName = "male" + imageNumber + ".png";
                }
                else
                {
                    imageName = "male5.png";
                }
            }
            else if (gender == "Female")
            {
                if (imageNumber >= 1 && imageNumber <= 5)
                {
                    imageName = "female" + imageNumber + ".png";
                }
                else
                {
                   
                    imageName = "female5.png";
                }
            }

            if (!string.IsNullOrEmpty(imageName))
            {
                pictureBox1.Image = Image.FromFile(imageName);
            }
            else
            {

                pictureBox1.Image = Image.FromFile("default.png");
            }
        }

        private int AgeCalc(int day, int month, int year)
        {
            DateTime currentDate = DateTime.Now;
            int currentDay = currentDate.Day;
            int currentMonth = currentDate.Month;
            int currentYear = currentDate.Year;

            
            int age = currentYear - year;

           
            if (currentMonth < month || (currentMonth == month && currentDay < day))
            {
                age--;
            }

            return age;
        }
        public void AddEntryToInfoFile(string name, int day, int month, int year, string gender)
        {
            string directoryPath = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(directoryPath, "info.txt");

            try
            {
                
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(name);
                    writer.WriteLine(day);
                    writer.WriteLine(month);
                    writer.WriteLine(year);
                    writer.WriteLine(gender);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the entry: " + ex.Message);
            }
        }
        public void Birthday()
        {
            tbd.Text = "Birthdays";
            listBox1.Items.Clear();

            string directoryPath = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(directoryPath, "info.txt");

            try
            {
               
                string[] lines = File.ReadAllLines(filePath);
                bool birthdayToday = false;
                
                for (int i = 0; i < lines.Length; i += 5)
                {

                    
                    if (i + 4 < lines.Length)
                    {
                        
                        string name = lines[i];
                        int day = int.Parse(lines[i + 1]);
                        int month = int.Parse(lines[i + 2]);
                        int year = int.Parse(lines[i + 3]);
                        string gender = lines[i + 4];
                        DateTime currentDate = DateTime.Now;
                        int currentMonth = currentDate.Month;
                        int currentDay = currentDate.Day;
                        
                        DateTime birthdate = new DateTime(year, month, day);

                        if (birthdate.Month == currentMonth && birthdate.Day == currentDay)
                        {
                            
                            birthdayToday = true;
                            string formattedData = $"Name: {name}, Birthdate: {birthdate.ToShortDateString()}, Gender: {gender}";
                            listBox1.Items.Add(formattedData);
                        }



                    }

                }
                if (!birthdayToday)
                {
                    
                    listBox1.Items.Add("Sorry, Nobody has Birthday Today");
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile("sad.png");
                    agebox.Text = "";
                }
                else
                {
                    pictureBox1.Visible=false;
                    agebox.Text = "";

                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found. Please make sure the 'info.txt' file exists in the same directory as the application.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file: " + ex.Message);
            }
            delete.Visible = false;
        }
        public void ReloadListBox()
        {
            delete.Visible = true;

            tbd.Text = "Friends";
            listBox1.Items.Clear();

            string directoryPath = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(directoryPath, "info.txt");

            try
            {
                
                string[] lines = File.ReadAllLines(filePath);

                
                for (int i = 0; i < lines.Length; i += 5)
                {
                   
                    if (i + 4 < lines.Length)
                    {
                       
                        string name = lines[i];
                        int day = int.Parse(lines[i + 1]);
                        int month = int.Parse(lines[i + 2]);
                        int year = int.Parse(lines[i + 3]);
                        string gender = lines[i + 4];

                       
                        DateTime birthdate = new DateTime(year, month, day);
                        
                        
                        string formattedData = $"Name: {name}, Birthdate: {birthdate.ToShortDateString()}, Gender: {gender}";
                        listBox1.Items.Add(formattedData);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found. Please make sure the 'info.txt' file exists in the same directory as the application.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file: " + ex.Message);
            }
        }
        private void friend_Click(object sender, EventArgs e)
        {
            ReloadListBox();
            agebox.Text = "";
        }

        private void birthday_Click(object sender, EventArgs e)
        {
            Birthday();
            agebox.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)  
            {
                string selectedData = listBox1.SelectedItem.ToString();

                
                string[] separatedData = selectedData.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (separatedData.Length >= 3)
                {
                    
                    string name = separatedData[0].Substring(6);  
                    string birthdateString = separatedData[1].Substring(11);
                    string gender = separatedData[2].Substring(8);

                    
                    string[] birthdateParts = birthdateString.Split('/');

                    if (birthdateParts.Length == 3)
                    {
                        
                        int month = int.Parse(birthdateParts[0]);
                        int day = int.Parse(birthdateParts[1]);
                        int year = int.Parse(birthdateParts[2]);
                        int age = AgeCalc(day, month, year);
                        agebox.Text = $"{age}"+" Years";
                        pictureBox1.Visible = true;
                        SetProfileImage(age, gender);


                    }
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)  
            {
                
                int selectedIndex = listBox1.SelectedIndex;

                
                string directoryPath = Directory.GetCurrentDirectory();
                string filePath = Path.Combine(directoryPath, "info.txt");
                string[] lines = File.ReadAllLines(filePath);

                try
                {
                    
                    lines = lines.Where((line, index) => index / 5 != selectedIndex).ToArray();

                    
                    File.WriteAllLines(filePath, lines);

                   
                    ReloadListBox();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File not found. Please make sure the 'info.txt' file exists in the same directory as the application.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the item: " + ex.Message);
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); 
            DialogResult result = form2.ShowDialog();

            if (result == DialogResult.OK)
            {                
                ReloadListBox();
            }
        }
    }



    
}
