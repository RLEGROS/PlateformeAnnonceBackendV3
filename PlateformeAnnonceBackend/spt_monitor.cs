//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlateformeAnnonceBackend
{
    using System;
    using System.Collections.Generic;
    
    public partial class spt_monitor
    {
        public System.DateTime lastrun { get; set; }
        public int cpu_busy { get; set; }
        public int io_busy { get; set; }
        public int idle { get; set; }
        public int pack_received { get; set; }
        public int pack_sent { get; set; }
        public int connections { get; set; }
        public int pack_errors { get; set; }
        public int total_read { get; set; }
        public int total_write { get; set; }
        public int total_errors { get; set; }
    }
}
