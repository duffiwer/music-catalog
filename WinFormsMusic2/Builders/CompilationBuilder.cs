using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMusic2.Models;

namespace WinFormsMusic2.Builders
{
    public class CompilationBuilder
    {
        private Compilation _compilation = new Compilation();
        public CompilationBuilder SetTitle(string title)
        {
            _compilation.Title = title;
            return this;
        }
        public CompilationBuilder AddTrack(Track track)
        {
            _compilation.Tracks.Add(track);
            return this;
        }
        public Compilation Build() => _compilation;
    }
}
