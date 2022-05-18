namespace ARMS.Presenter
{
    public interface IRecipeParamUPloadView
    {
        string[] RunRecipeParams { get; set; }

        string SpecClusterRecipe { set; }
        string SpecFrontsideRecipe { set; }
        string SpecInspectionDies { set;}
        string SpecInspectionColumns { set; }
        string SpecInspectionRows { set; }
        string ToolClusterRecipe { set; }
        string ToolFrontsideRecipe { set; }
        string ToolInspectionDies { set; }
        string ToolInspectionColumns { set; }
        string ToolInspectionRows { set; }
    }
}