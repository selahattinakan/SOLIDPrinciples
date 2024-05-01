using SOLIDPrinciples.DependencyInversionBadUsage;
using SOLIDPrinciples.DependencyInversionGoodUsage;

Console.WriteLine("Welcome to SOLID Principles");




Console.WriteLine("Bad Usage");
/*Bad Usage*/
var ProductService = new SOLIDPrinciples.DependencyInversionBadUsage.ProductService(new SOLIDPrinciples.DependencyInversionBadUsage.ProductRepositorySQL());

ProductService.GetAll().ForEach(x =>Console.WriteLine(x));



Console.WriteLine("Good Usage");
/*Good Usage*/
var ProductServiceGoodSQL = new SOLIDPrinciples.DependencyInversionGoodUsage.ProductService(new SOLIDPrinciples.DependencyInversionGoodUsage.ProductRepositorySQL());

ProductServiceGoodSQL.GetAll().ForEach(x => Console.WriteLine(x));

var ProductServiceGoodOracle = new SOLIDPrinciples.DependencyInversionGoodUsage.ProductService(new SOLIDPrinciples.DependencyInversionGoodUsage.ProductRepositoryOracle());

ProductServiceGoodOracle.GetAll().ForEach(x => Console.WriteLine(x));


