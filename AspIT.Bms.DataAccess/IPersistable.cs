namespace AspIT.Bms.DataAccess
{
    /// <summary>
    /// Represent an entity that can be persisted in a data source.
    /// </summary>
    public interface IPersistable
    {
        /// <summary>
        /// The unique id for the entity implementing <see cref="IPersistable"/>.
        /// </summary>
        int Id { get; set; }
    }
}