namespace ARMS.Presenter
{
    public interface IRecipeParamUPloadView
    {
        string ClusterRecipe { get; set; }
        string FrontsideRecipe { get; set; }
        string InspectionDies { get; set; }
        string InspectionColumns { get; set; }
        string InspectionRows { get; set; }
    }
}