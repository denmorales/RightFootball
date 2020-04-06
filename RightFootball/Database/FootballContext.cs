// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FootballContext.cs" company="">
//   
// </copyright>
// <summary>
//   The football context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RightFootball.Database
{
    using System.Data.Entity;

    /// <summary>
    /// The football context.
    /// </summary>
    public class FootballContext : DbContext
    {
        /// <summary>
        /// Gets or sets the commands.
        /// </summary>
        public DbSet<FootballCommand> Commands { get; set; }
    }
}