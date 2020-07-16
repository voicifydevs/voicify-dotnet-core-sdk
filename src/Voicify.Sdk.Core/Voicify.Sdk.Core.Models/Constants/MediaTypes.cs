using System;
using System.Collections.Generic;
using System.Text;

namespace Voicify.Sdk.Core.Models.Constants
{
    /// <summary>
    /// Different media types used in <see cref="Voicify.Sdk.Core.Models.Model.MediaItemModel"/>
    /// </summary>
    public sealed class MediaTypes
    {
        public const string AudioFile = nameof(AudioFile);
        public const string ImageFile = nameof(ImageFile);
        public const string VideoFile = nameof(VideoFile);
        public const string TextFile = nameof(TextFile);
    }
}
