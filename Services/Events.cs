using System.ComponentModel.DataAnnotations;

namespace EventEase_App.Services;
public class Event
{
    public int ID {get; set;}
    [Required(ErrorMessage ="Name is required.")]
    public string? Name {get; set;}
    [Required(ErrorMessage = "Date is required")]
    public DateOnly? Date {get; set;}
    [Required(ErrorMessage = "Location is required")]
    public string? Location {get; set;}
    public string? Description {get; set;}

    public int Attending = 0;
}

public class EventManager
{
    private List<Event> Events = new List<Event>{new Event{Name="Test Event 1", Date=DateOnly.MaxValue, Location="Jacksonville, FL", Description="This is an example event description for Test Event 1", ID=1}};
    static int IDCount = 2;

    public void AddEvent(Event e)
    {
        e.ID = IDCount;
        IDCount++;
        Events.Add(e);
    }

    public void RemoveEvent(Event e)
    {
        Events.Remove(e);
    }

    public List<Event> ListEvents()
    {
        return Events;
    }
}