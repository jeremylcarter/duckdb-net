// <auto-generated/>

using System.Runtime.InteropServices;

namespace DuckDb.Bindings
{
    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>duckdb_timestamp</unmanaged>
    /// <unmanaged-short>duckdb_timestamp</unmanaged-short>
    [StructLayout(LayoutKind.Sequential, Pack = 0, CharSet = CharSet.Unicode)]
    internal struct DuckdbTimestamp
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>date</unmanaged>
        /// <unmanaged-short>date</unmanaged-short>
        public DuckdbDate Date;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>time</unmanaged>
        /// <unmanaged-short>time</unmanaged-short>
        public DuckdbTime Time;
    }
}