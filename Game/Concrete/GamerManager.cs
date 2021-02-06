using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class GamerManager : IGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        List<Gamer> listOfGamers = new List<Gamer>();

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Register(Gamer gamer)
        {
            if (_gamerCheckService.IsItRealPerson(gamer))
            {
                listOfGamers.Add(gamer);
                Console.WriteLine("Kaydınız başarıyla tamamlandı.");
                Console.WriteLine("Nationality Id\t: " + gamer.NationalityId + "\n" + "Gamer Name\t: " + gamer.FirstName + "\n" + "Gamer Last Name\t: " 
                    + gamer.LastName + "\n" + "Gamer Birth Y.\t: " + gamer.DateOfBirthYear + "\n" + "Gamer User Name\t: " + gamer.UserName + "\n" 
                    + "Gamer Email\t: " + gamer.Email + "\n" + "Gamer Password\t: " + gamer.Password + "\n");
            }
            else
                Console.WriteLine("Kayıt tamamlanamadı.");
        }

        public void NormalRegister(Gamer gamer)
        {
            listOfGamers.Add(gamer);
            Console.WriteLine("Kaydınız başarıyla tamamlandı.");
            Console.WriteLine("Nationality Id\t: " + gamer.NationalityId + "\n" + "Gamer Name\t: " + gamer.FirstName + "\n" + "Gamer Last Name\t: "
                    + gamer.LastName + "\n" + "Gamer Birth Y.\t: " + gamer.DateOfBirthYear + "\n" + "Gamer User Name\t: " + gamer.UserName + "\n"
                    + "Gamer Email\t: " + gamer.Email + "\n" + "Gamer Password\t: " + gamer.Password + "\n");
        }

        public void UpdateUserName(Gamer gamer,string newName)
        {
            gamer.UserName = newName;
            Console.WriteLine("Güncelleştirme başarıyla tamamlandı.");
        }
        public void UpdateEmail(Gamer gamer,string newEmail)
        {
            gamer.Email = newEmail;
            Console.WriteLine("Güncelleştirme başarıyla tamamlandı.");
        }
        public void UpdatePassword(Gamer gamer,string newPassword)
        {
            gamer.Password = newPassword;
            Console.WriteLine("Güncelleştirme başarıyla tamamlandı.");
        }

        public void Delete(Gamer gamer)
        {
            char val;string pw;
            Console.WriteLine("Hesabı silmek istediğinize emin misiniz ? (e/h)");
            val = Convert.ToChar(Console.ReadLine());
            if (val == 'e')
            {
                Console.WriteLine("Lütfen şifre giriniz..");
                pw = Console.ReadLine();
                if (pw == gamer.Password)
                {
                    listOfGamers.Remove(gamer);
                    Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
                }
                else
                    Console.WriteLine("Şifre yanlış!");
            }
            else
                Console.WriteLine("--");           
        }
    }
}
