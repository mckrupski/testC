namespace testC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            //Application.Exit();

            //szeroko�� okna aplikacji
            int windowWidth = Size.Width;

            //wysko�� okna aplikacji
            int windowHeight = Size.Height;

            windowWidth -= button1.Width;
            windowHeight -= button1.Height;

            //instalizacja generatora liczb losowych 
            Random rdn = new Random();

            //losowa odleg�o�� od lewej - nie wi�cej ni� szeroko�� okna
            int randomLeft = rdn.Next(windowWidth);


            int randomTop = rdn.Next(windowHeight);

            //przesuwamy guzik
            //location musi by� przekazany jako punkt na ekranie
            Point topLeftCorner = new Point(randomLeft, randomTop);
            //centerButton to nazwa (atrybut Name) mojego guzika
            button1.Location = topLeftCorner;

        }
    }
}