namespace StudentGradeApplication
{
    public partial class frmStudentGradeApplication : Form
    {
        public frmStudentGradeApplication()
        {
            InitializeComponent();
        }

        private void avgBtn_Click(object sender, EventArgs e)
        {
            double clveGrade = Convert.ToDouble(clveTxt.Text);
            double histGrade = Convert.ToDouble(histTxt.Text);
            double engGrade = Convert.ToDouble(engTxt.Text);
            double sciGrade = Convert.ToDouble(sciTxt.Text);
            double compGrade = Convert.ToDouble(compTxt.Text);

            double GradeAdd = clveGrade + histGrade + engGrade + sciGrade + compGrade;

            double GradeDiv = GradeAdd / 5;

            string UrGrade = "The General average of " +
                nameTxt.Text + " is " + GradeDiv;

            string Passed = "Student Passed! \n" + UrGrade;

            string Failed = "Student Failed! \n" + UrGrade;

            string Avg = ( GradeDiv >= 75 ) ? Passed : Failed;

            Popup.Text = Avg;
        }
    }
}