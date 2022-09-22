using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public abstract class Forme
    {
        private string type;
        private Color color;

        public string Type { get => type; set => type = value; }
        public Color Color { get => color; set => color = value; }

        protected abstract void Dessiner(Graphics graphics);

        public Bitmap Dessiner()
        {
            Bitmap bitmap = new Bitmap(100, 100);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Dessiner(graphics);
            }
            return bitmap;
        }

        public abstract string ObtenirType();

        public event EventHandler<int> ValeurIdChanged;
    }
}
