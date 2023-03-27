using System;
using System.Collections.Generic;

namespace VisNetwork.Blazor.Models
{
    public class NodeSelectEventArguments : EventArgs
    {
        public List<string>? SelectedNodes { get; set; } 
    }
}
