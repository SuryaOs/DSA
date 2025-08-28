namespace dsaproblem.Striver.LinkedList.DoublyLinkedList;

public class BrowserDirector
{
    public static void Play()
    {
        Browser b = new("Tuf.com");
        b.Visit("Google.Com");
        b.Visit("Facebook.com");
        b.Visit("Instagram.com");
        b.back(3);
        b.forward(2);
        b.Visit("TuF.com");
        b.back(1);
        b.forward(1);
        b.back(100);
        b.forward(100);
    }
}
public class Browser
{
    public Page page;
    public Browser(string homePage)
    {
        page = new Page(homePage);
        Console.WriteLine($"Welcome To Home Page - {page.url}");
    }
    public void Visit(string url)
    {
        Page newPage = new Page(url);
        page.next = newPage;
        newPage.back = page;
        page = page.next;
        Console.WriteLine($"Welcome to {page.url}");
    }
    public void back(int steps)
    {
        while (steps-- > 0 && page.back != null)
        {
            page = page.back;
        }
        Console.WriteLine($"You are back to {page.url}");
    }
    public void forward(int steps)
    {
        while (steps-- > 0 && page.next != null)
        {
            page = page.next;
        }

        Console.WriteLine($"You moved forward to {page.url}");
    }
}
public class Page
{
    public string url;
    public Page next;
    public Page back;
    public Page(string url)
    {
        this.url = url;
        this.next = null;
        this.back = null;
    }
}