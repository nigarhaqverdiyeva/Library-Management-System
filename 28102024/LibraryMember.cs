namespace _28102024;
public sealed class LibraryMember : Person
{
    public DateTime MembershipData { get; set; }
    public LibraryMember(string name, DateTime membershipData) : base(name)
    {
        MembershipData=membershipData;
    }
}
