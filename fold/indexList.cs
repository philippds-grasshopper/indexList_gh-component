using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

using System.Linq;

namespace template_component

{
    public class vanillaComponent : GH_Component
    {
        GH_Document GrasshopperDocument;
        IGH_Component Component;
        
        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public vanillaComponent(): base("indexList", "iL", "returns indexes of list items", "MyComponents", "Subcategory")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddScriptVariableParameter("list", "list", "list", GH_ParamAccess.list);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddIntegerParameter("indexList", "indexList", "indexList", GH_ParamAccess.list);
           
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            List<dynamic> list = new List<dynamic>();
            List<int> indexList = new List<int>();
            DA.GetDataList(0, list);
            
                       
            if(list.Count() != 0)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    indexList.Add(i);
                }
            }
            else
            {
                indexList.Add(0);
            }

            DA.SetDataList(0, indexList);
        }


        /// <summary>
        /// Provides an Icon for every component that will be visible in the User Interface.
        /// Icons need to be 24x24 pixels.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                // You can add image files to your project resources and access them like this:
                //return Resources.IconForThisComponent;
                return indexList.Properties.Resources.iL;
            }
        }

        /// <summary>
        /// Each component must have a unique Guid to identify it. 
        /// It is vital this Guid doesn't change otherwise old ghx files 
        /// that use the old ID will partially fail during loading.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("FD0AC928-DD95-4526-B63C-13A230E20BEB"); }
        }
        
    }
}
