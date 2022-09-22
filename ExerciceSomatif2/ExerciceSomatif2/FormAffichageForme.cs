using ExerciceSomatif2.Models;
using System.Drawing;

namespace ExerciceSomatif2
{
    public partial class FormAffichageForme : Form
    {
        private readonly Controler controler;

        public FormAffichageForme()
        {
            controler = new Controler();
            InitializeComponent();
            Abonnement();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            controler.ChangerForme();
        }

        private void Abonnement()
        {
            controler.ChangementFormeCourantEvent += Control_ChangementFormeCourant;
        }
        private void Control_ChangementFormeCourant(object? sender, Forme forme)
        {
            control1.Forme = forme;
            controler.Id = (controler.Id + 1) % controler.Formes.Count;
        }
    }
}