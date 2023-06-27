namespace MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral
    {
        public ICollection<IPrivate> Privates { get; set; }
    }
}
