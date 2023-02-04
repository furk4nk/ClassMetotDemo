using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassMetotDemo
{
	public class Musteri
	{
		public int MusteriId { get; set; }
		public string MusteriEMail { get; set; }
		public string MusteriName { get; set; }
		public int MusteriYaş { get; set; }
	}
	public class MusteriManager : Musteri, IManager<Musteri>
	{
		public void Delete(Musteri t)
		{
			Console.WriteLine("müşteri silindi ,{}",t.MusteriName);
		}

		public void Insert(Musteri t)
		{
			Console.WriteLine("müşteri eklendi",t.MusteriName);
		}

		public void Update(Musteri t)
		{
			Console.WriteLine("müşteri güncellendi "+t.MusteriName+t.MusteriEMail+t.MusteriYaş);
		}

		public List<Musteri> GetList()
		{
			Console.WriteLine("müşteri listesi");
			List<Musteri> liste= new List<Musteri>();
			Musteri m= new Musteri() { MusteriEMail = "abc", MusteriId = 1, MusteriName = "ahmet", MusteriYaş = 19 };
			liste.Add(m);
			return liste;
		}
	}
}
