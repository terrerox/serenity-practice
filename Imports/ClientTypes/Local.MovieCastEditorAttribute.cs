using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace practice1.Local
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "practice1.Local.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}
