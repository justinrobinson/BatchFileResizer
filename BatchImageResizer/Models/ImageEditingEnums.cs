using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchImageResizer
{
    public enum AlignmentType
    {
        topleft,
        topcenter,
        topright,
        middleleft,
        middlecenter,
        middleright,
        bottomleft,
        bottomcenter,
        bottomright
    }

    public enum StreamCarvingType
    {
        pad,
        crop,
        stretch,
        carve
    }

    public enum ScaleType
    {
        down,
        both,
        canvas
    }

    public enum ImageFormatType
    {
        jpg,
        gif,
        png
    }

}
