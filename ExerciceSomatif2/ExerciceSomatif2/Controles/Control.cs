using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceSomatif2.Controles
{
    public partial class Control : UserControl
    {
        private Forme forme;

        public Forme Forme
        {
            get => forme;
            set { SetForme(value); }
        }

        private void SetForme(Forme? forme)
        {
            if (forme is null)
            {
                lblType.Text = "";
                picboxForme.Image = null;
            }
            else
            {
                Desabonner();
            }
            this.forme = forme;
            if (forme is not null)
            {
                Abonner();
                InitForme();
            }
        }

        private void Abonner()
        {
            forme.ValeurIdChanged += ValeurIdChanged;
        }

        private void Desabonner()
        {
            if (forme is not null)
            {
                forme.ValeurIdChanged -= ValeurIdChanged;
            }
        }

        private void InitForme()
        {
            lblType.Text = forme.Type;
            picboxForme.Image = forme.Dessiner();
        }

        public Control()
        {
            InitializeComponent();
        }

        private void ValeurIdChanged(object? sender, int valeur)
        {
            lblType.Text = valeur.ToString();
        }

    }
}

