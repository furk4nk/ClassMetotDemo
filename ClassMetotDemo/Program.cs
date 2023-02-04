using ClassMetotDemo;

MusteriManager m = new MusteriManager();

foreach (var item in m.GetList())
{
	Console.WriteLine(item.MusteriName);
	Console.WriteLine(item.MusteriEMail);
	Console.WriteLine(item.MusteriYaş);
}