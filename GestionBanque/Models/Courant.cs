namespace GestionBanque.Models
{
    public class Courant
    {
        #region Attributs
        private string _Numero;
        private double _Solde;
        private double _LigneDeCredit;
        private Personne _Titulaire;
        #endregion

        #region Propriétés
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }

        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set {
                if ( value < 0 ) return; // A remplacer plus tard par une exception
                _LigneDeCredit = value; 
            }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            set { _Titulaire = value; }
        } 
        #endregion

        #region Méthodes
        public void Retrait(double Montant)
        {
            if ( Montant <= 0 ) return; // A remplacer par une exception

            if ( Solde - Montant < -LigneDeCredit ) return; // A remplacer par une exception

            Solde -= Montant;


        }

        public void Depot(double Montant)
        {
            if ( Montant <= 0 ) return; // A remplacer par une exception
            //Solde = Solde + Montant;
            Solde += Montant;
        }
        #endregion

    }
}
