namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RolarDadoButton_Clicked(object sender, EventArgs e)
        {
            //PEgar o numero que o usuario selecionou
            int selectedSides = Convert.ToInt32(SidesPicker.SelectedItem);

            //usar esse numero como "limitar do metdo Random"
            //sortear um numero utilizando o metodo Random
            //PODERIA SER ASSIM TAMBEM:
            /*
                Random random = new Random();
                int drawnNumber = random.Next(1, selectedSides + 1);
            */
            int drawnnumber = new Random().Next(1, selectedSides + 1);

            //Pegar esse resaultado e exibir no label
            ResulLabel.Text = drawnnumber.ToString();
        }
    }

}
