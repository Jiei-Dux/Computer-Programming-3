namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }


        // ========== // ========== // ========== // ========== // ========== //


        private void cmbDay_Dropdown(object sender, EventArgs e)
        {
            cmbBox_Day.Items.Add("-Day-");
            for (int Day = 1; Day <= 31; Day++)
            {
                cmbBox_Day.Items.Add(Day);
            }
        }

        private void cmbMonth_Dropdown(object sender, EventArgs e)
        {
            cmbBox_Month.Items.Add("-Month-");
            for (int Month = 1; Month <= 12; Month++)
            {
                cmbBox_Month.Items.Add(Month);
            }
        }

        private void cmbYear_Dropdown(object sender, EventArgs e)
        {
            cmbBox_Year.Items.Add("-Year-");
            for (int Year = 1900; Year <= DateTime.UtcNow.Year; Year++)
            {
                cmbBox_Year.Items.Add(Year);
            }
        }

        private void SchoolProgram_Dropdown(object sender, EventArgs e)
        {
            cmbBox_Program.Items.Add("-Select Program-");
            cmbBox_Program.Items.Add("BS in Information Technology");
            cmbBox_Program.Items.Add("BS in Computer Science");
            cmbBox_Program.Items.Add("BS in Information Systems");
            cmbBox_Program.Items.Add("BS in Business Administration");
            cmbBox_Program.Items.Add("BS in Accountancy");
            cmbBox_Program.Items.Add("BS in Accounting Information System");
            cmbBox_Program.Items.Add("BS in Management Accounting");
            cmbBox_Program.Items.Add("BS in Retail Technology and Consumer Science");
            cmbBox_Program.Items.Add("BS in Hospitality Mangement");
            cmbBox_Program.Items.Add("BS in Culinary Management");
            cmbBox_Program.Items.Add("BS in Tourism Management");
            cmbBox_Program.Items.Add("BS in Computer Engineering");
            cmbBox_Program.Items.Add("BS in Marine Transportation");
            cmbBox_Program.Items.Add("BS in Marine Engineering");
            cmbBox_Program.Items.Add("BS in Naval Architecture and Marine Engineering");
            cmbBox_Program.Items.Add("Bachelor of Multimedia Arts");
            cmbBox_Program.Items.Add("BA in Communication");
        }


        // ========== // ========== // ========== // ========== // ========== //


        private void regBtn_Click(object sender, EventArgs e)
        {
            overloadedMethods Class2 = new overloadedMethods();


            // ========== // ========== // ========== // ========== // ========== //


            Class2.FName = TxtBox_FName.Text;
            Class2.LName = TxtBox_LName.Text;
            Class2.MName = TxtBox_MName.Text;

            Class2.ChosenDay = cmbBox_Day.SelectedItem.ToString();
            Class2.ChosenMonth = cmbBox_Month.SelectedItem.ToString();
            Class2.ChosenYear = cmbBox_Year.SelectedItem.ToString();

            Class2.ChosenProgram = cmbBox_Program.Text;


            // ========== // ========== // ========== // ========== // ========== //


            if (maleBtn.Checked)
            {
                Class2.Gender = maleBtn.Text;
            }

            if (femaleBtn.Checked)
            {
                Class2.Gender = femaleBtn.Text;
            }


            // ========== // ========== // ========== // ========== // ========== //





            // ========== // ========== // ========== // ========== // ========== //


            MessageBox.Show(
                Class2.INFO(
                    Class2.FName,
                    Class2.MName,
                    Class2.LName,
                    Class2.Gender,
                    Class2.ChosenDay,
                    Class2.ChosenMonth,
                    Class2.ChosenYear,
                    Class2.ChosenProgram
                    )
                );

            MessageBox.Show(
                Class2.INFO(
                    Class2.FName,
                    Class2.MName,
                    Class2.LName,
                    Class2.ChosenProgram
                    )
                );

            MessageBox.Show(
                Class2.INFO(
                    Class2.FName,
                    Class2.LName,
                    Class2.ChosenProgram
                    )
                );
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            string imageFilePath = "";

            try
            {
                OpenFileDialog Popup = new OpenFileDialog();

                Popup.Filter = "JPG files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (Popup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageFilePath = Popup.FileName;
                    PB_userPFP.ImageLocation = imageFilePath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR LOL");
            }
        }
    }


    // ========== // ========== // ========== // ========== // ========== //


    class overloadedMethods
    {

        private string
            fname = string.Empty,
            mname = string.Empty,
            lname = string.Empty,

            DayChosen = string.Empty,
            MonthChosen = string.Empty,
            YearChosen = string.Empty,

            gender = string.Empty,

            ProgramChosen = string.Empty;


        // ========== // ========== // ========== // ========== // ========== //


        public string FName
        {
            get { return fname; }
            set { fname = value; }
        }

        public string MName
        {
            get { return mname; }
            set { mname = value; }
        }

        public string LName
        {
            get { return lname; }
            set { lname = value; }
        }

        public string ChosenDay
        {
            get { return DayChosen; }
            set { DayChosen = value; }
        }

        public string ChosenMonth
        {
            get { return MonthChosen; }
            set { MonthChosen = value; }
        }

        public string ChosenYear
        {
            get { return YearChosen; }
            set { YearChosen = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string ChosenProgram
        {
            get { return ProgramChosen; }
            set { ProgramChosen = value; }
        }


        // ========== // ========== // ========== // ========== // ========== //


        public string INFO(
            string fname,
            string lname,
            string ProgramChosen)
        {
            string INFOW =
                "Student Name: " + fname + " "
                                 + lname + "\n"
                                 +

                "Program: " + ProgramChosen;

            return INFOW;
        }

        public string INFO(
            string fname,
            string mname,
            string lname,
            string ProgramChosen)
        {
            string INFOW =
                "Student Name: " + FName + " "
                                 + MName + " "
                                 + LName + "\n"
                                 +

                "Program: " + ProgramChosen;

            return INFOW;
        }

        public string INFO(
            string fname,
            string mname,
            string lname,
            string gender,
            string DayChosen,
            string MonthChosen,
            string YearChosen,
            string ProgramChosen)
        {
            string INFOW =
                "Student Name: " + FName + " "
                                 + MName + " "
                                 + LName + "\n"
                                 +

                "Gender: " + Gender + "\n"
                           +

                "Date of Birth: " + ChosenDay + " / "
                                  + ChosenMonth + " / "
                                  + ChosenYear + "\n"
                                  +

                "Program: " + ChosenProgram;

            return INFOW;
        }
    }
}