using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace template_component
{
    public class template_info : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "indexList";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return indexList.Properties.Resources.iL;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "This component returns list indexes of any type.";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("FD0AC928-DD95-4526-B63C-13A230E20BEB"); // Tools -> Create Guid 5.
            }
        }
        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "Philipp Siedler";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "p.d.siedler@gmail.com";
            }
        }
    }
}
