using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Writing.Formatting;
using VDS.RDF.Query;
using VDS.RDF.Query.Datasets;


namespace OwlDotNetTesting
{
    class Program
    {

        static void Main(string[] args)
        {
            loadOwl("");
            Console.ReadLine();
        }
        static void loadOwl(string ruta)
        {
            //string path = Application.StartupPath.ToString() + "\\JudoOntology.owl";
           // string path = Application.StartupPath.ToString() + "\\JudoOntology.owl";
            string path = Application.StartupPath.ToString() + "\\FoodOntologyRecomender.owl";
            IGraph g = new Graph();
            g.LoadFromFile(path, new RdfXmlParser());
            try
            {
                /*foreach (IUriNode u in g.Nodes.UriNodes())
                  {
                      //Write the URI to the Console
                      Console.WriteLine(u.Uri.ToString());
                  }   

                  
                Console.WriteLine(g.BaseUri);foreach (Triple u in g.Triples)
                  {
                      //Write the URI to the Console
                      Console.WriteLine(u.ToString());
                  }*/


                //Fill in the code shown on this page here to build your hello world application

                /*
                IUriNode dotNetRDF = g.CreateUriNode(UriFactory.Create("http://www.dotnetrdf.org"));
                IUriNode says = g.CreateUriNode(UriFactory.Create("http://example.org/says"));
                ILiteralNode helloWorld = g.CreateLiteralNode("Hello World");
                ILiteralNode bonjourMonde = g.CreateLiteralNode("Bonjour tout le Monde", "fr");

                g.Assert(new Triple(dotNetRDF, says, helloWorld));
                g.Assert(new Triple(dotNetRDF, says, bonjourMonde));

                Console.WriteLine();
                Console.WriteLine("Raw Output");
                Console.WriteLine();*/

                /*
                foreach (Triple t in g.Triples)
                {
                   
                    Console.WriteLine(t.ToString());
                }
                foreach (IUriNode u in g.Nodes.UriNodes())
                {
                    //Write the URI to the Console
                    Console.WriteLine(u.Uri.ToString());
                }*/

                //Create a Parameterized String
                SparqlParameterizedString queryString = new SparqlParameterizedString();

                //Add a namespace declaration
                queryString.Namespaces.AddNamespace("rdf", new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#"));
                queryString.Namespaces.AddNamespace("owl", new Uri("http://www.w3.org/2002/07/owl#"));
                queryString.Namespaces.AddNamespace("xsd", new Uri("http://www.w3.org/2001/XMLSchema#"));
                queryString.Namespaces.AddNamespace("rdfs", new Uri("http://www.w3.org/2000/01/rdf-schema#"));
                //Set the SPARQL command
                //For more complex queries we can do this in multiple lines by using += on the
                //CommandText property
                //Note we can use @name style parameters here

                //      queryString.CommandText = "SELECT * WHERE { ?s ex:property @value }";
                /*
                queryString.CommandText = "SELECT ?individual ?class WHERE {?individual"+
                    " rdf:type owl:NamedIndividual. "+      
                    "?class rdf:type owl:Class.}";*/
                /*
            // get all class in the model
            queryString.CommandText = "SELECT ?s WHERE { ?s rdf:type owl:Class } "; */




                //Inject a Value for the parameter
                // queryString.SetUri("value", new Uri("http://example.org/value"));
                //When we call ToString() we get the full command text with namespaces appended as PREFIX
                //declarations and any parameters replaced with their declared values

                Console.WriteLine(queryString.ToString());

                //We can turn this into a query by parsing it as in our previous example
                SparqlQueryParser parser = new SparqlQueryParser();
                SparqlQuery query = parser.ParseFromString(queryString);
                InMemoryDataset ds = new InMemoryDataset(g);
                //Get the Query processor
                ISparqlQueryProcessor processor = new LeviathanQueryProcessor(ds);
                Object results = processor.ProcessQuery(query);
                if (results is SparqlResultSet)
                {
                    SparqlResultSet r = results as SparqlResultSet;

                    foreach (SparqlResult res in r)
                    {
                        SparqlFormatter format = new SparqlFormatter();
                       Console.WriteLine(res.ToString(format));
                    }
                }
            }
            catch (RdfParseException ex)
            {
                Console.WriteLine("Parser Error");
                Console.WriteLine(ex.Message);
            }
        }
        static void buscarTripleta()
        {
            string path = Application.StartupPath.ToString() + "\\FoodOntologyRecomender.owl";
            IGraph g = new Graph();
            g.LoadFromFile(path, new RdfXmlParser());
            try
            {

            }
            catch (RdfParseException ex)
            {
                Console.WriteLine("Parser Error");
                Console.WriteLine(ex.Message);
            }
        }
      
    }

    
}
