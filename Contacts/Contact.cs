using System;
using System.Drawing;

namespace Contacts
{
    /// <summary>
    /// Classe Contact
    /// mémorise les informations du contact
    /// </summary>
    [SerializableAttribute]
    public class Contact : IComparable
//    public class Contact
    {
        private string nom;
        private string prenom;
        private string tel;
        private Image photo;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">nom</param>
        /// <param name="prenom">prénom</param>
        /// <param name="tel">téléphone</param>
        /// <param name="photo">photo</param>
        public Contact(string nom, string prenom, string tel, Image photo)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.photo = photo;
        }

        /// <summary>
        /// getter sur nom
        /// </summary>
        /// <returns>nom</returns>
        public string getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// getter sur prenom
        /// </summary>
        /// <returns>prenom</returns>
        public string getPrenom()
        {
            return this.prenom;
        }

        /// <summary>
        /// getter sur tel
        /// </summary>
        /// <returns>tel</returns>
        public string getTel()
        {
            return this.tel;
        }

        /// <summary>
        /// getter sur photo
        /// </summary>
        /// <returns>photo</returns>
        public Image getPhoto()
        {
            return this.photo;
        }

        /// <summary>
        /// informations sur le contact
        /// </summary>
        /// <returns>nom + prenom + (tel)</returns>
        public override string ToString()
        {
            return this.nom + " " + this.prenom + " (" + this.tel + ")";
        }

        /// <summary>
        /// Comparaison des noms pour le tri
        /// </summary>
        /// <param name="obj">contact à comparer</param>
        /// <returns>comparaison sur le nom</returns>
        public int CompareTo(object obj)
        {
            return nom.CompareTo(((Contact)obj).getNom());
        }
    }
}
