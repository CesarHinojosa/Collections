namespace CH.Collections.UI
{

    //try not to create variables that yo uonly use once
    public partial class MainForm : Form
    {
        //fields
        private string[] entreeNames =
        {
            "Pizza", "Hamburger", "Salad", "Sushi", "Bla"
        };

        //properties

        //constructors

        
        public MainForm()
        {
            InitializeComponent();

            //foreach(string name in entreeNames)
            //{
            //    RadioButton rdoEntree = new RadioButton();
            //    rdoEntree.Text = name;
            //    Controls.Add(rdoEntree); // controls is a list and not a array 
            //}

            for (int i = 0; i < entreeNames.Length; i++)
            {
                CreateEntreeRadio(entreeNames[i]);
            }
            
        }

        private void CreateEntreeRadio(string entreeName)
        {
            RadioButton rdoEntree = new RadioButton();
            rdoEntree.Text = entreeName;

            //location
            //int top = (10 + rdoEntree.Size.Height) * i + 10;
            //rdoEntree.Location = new Point(10, top);

            rdoEntree.Font = new Font(FontFamily.GenericSansSerif, 14);
            rdoEntree.AutoSize = true;

            Controls.Add(rdoEntree);
        }


        //methods

        private void btnAddNewEntree_Click(object sender, EventArgs e)
        {
            //instance
            AddNewEntreeForm frmNewEntree = new AddNewEntreeForm();
            DialogResult dlgResult = frmNewEntree.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
              
                CreateEntreeRadio(frmNewEntree.EntreeName);
            }
        }
    }
}