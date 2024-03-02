using static System.Console;

// Создайте класс «Веб-сайт». Необходимо хранить в полях класса: название сайта, путь к сайту,
// описание сайта, ip адрес сайта. Реализуйте методы класса для ввода данных, вывода данных,
// реализуйте доступ к отдельным полям через методы класса.

class Website
{
    private string siteName;
    private string siteUrl;
    private string siteDescription;
    private string siteIpAddress;

    public void SetSiteName(string name)
    {
        siteName = name;
    }

    public string GetSiteName()
    {
        return siteName;
    }

    public void SetSiteUrl(string url)
    {
        siteUrl = url;
    }

    public string GetSiteUrl()
    {
        return siteUrl;
    }

    public void SetSiteDescription(string description)
    {
        siteDescription = description;
    }

    public string GetSiteDescription()
    {
        return siteDescription;
    }

    public void SetSiteIpAddress(string ipAddress)
    {
        siteIpAddress = ipAddress;
    }

    public string GetSiteIpAddress()
    {
        return siteIpAddress;
    }

    public void InputData()
    {
        WriteLine("Введите название сайта:");
        siteName = ReadLine();

        WriteLine("Введите путь к сайту:");
        siteUrl = ReadLine();

        WriteLine("Введите описание сайта:");
        siteDescription = ReadLine();

        WriteLine("Введите IP адрес сайта:");
        siteIpAddress = ReadLine();
    }

    public void Show()
    {
        WriteLine($"Название сайта: {siteName}");
        WriteLine($"Путь к сайту:   {siteUrl}");
        WriteLine($"Описание сайта: {siteDescription}");
        WriteLine($"IP адрес сайта: {siteIpAddress}");
    }
}

class Program
{
    static void Main()
    {
        Website myWebsite = new Website();

        myWebsite.InputData();
        WriteLine("\nВведённые данные:");
        myWebsite.Show();
    }
}