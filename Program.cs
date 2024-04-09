class FindArry
{
    private static void Main(string[] args)
    {
        string [] mystudents = { "Quan", "Thao", "Bao","Quyen","Linh", "Dunb", "Nghia", "Tuan","Lan"};
        Console.WriteLine("Nhap 1 ten tu ban phim");    
        string name = Console.ReadLine();
        bool isHas=false;
        for (int i=0;i<mystudents.Length;i++)
        {
        if (mystudents[i].Equals(name))
        {
            Console.WriteLine("Co sinh vien o trong lop");
            isHas=true;
            break;

        }
        }
        if (!isHas)
        {
            Console.WriteLine("Khong co sinh vien trong lop");
        }
    }
}
