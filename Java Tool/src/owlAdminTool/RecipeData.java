package owlAdminTool;

public class RecipeData {
	protected Double RecetaFat;
	protected Double RecetaSalt;
	protected Double RecetaProtein;
	protected Double RecetaSaturates;
	protected Double RecetaCalorias;
	protected Double RecetaCarbs;
	protected Double RecetaSugar;
	protected Double RecetaFibre;
    protected String[] ingredientes;   
	public  RecipeData() 
	{
		this.RecetaFat 			= (double)0;
		this.RecetaSalt 		= (double)0;
		this.RecetaProtein 		= (double)0;
	    this.RecetaSaturates 	= (double)0;
	    this.RecetaCalorias 	= (double)0;
	    this.RecetaCarbs 		= (double)0;
	    this.RecetaSugar		= (double)0;
	    this.RecetaFibre 		= (double)0;
	}
	public void asignarValoresDataPropeties(Double Fat,Double Salt, Double Protein, Double Saturates,
			Double Calorias,Double Carbs, Double Sugar,Double Fibre )
	{
		
		this.RecetaFat = Fat;
		
	}

}
