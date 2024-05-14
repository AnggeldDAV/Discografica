using Discografica;

IFactory Fabrica = new Fabrica01();
Fabrica.Validador = new Validador01();
Lista02 Lista = new ();


IReproducible reproducible1 = Fabrica.CreaRepoducible(TipoRepoducible.Canciones);
IReproducible reproducible2 = Fabrica.CreaRepoducible(TipoRepoducible.Videos);
IReproducible reproducible3 = Fabrica.CreaRepoducible(TipoRepoducible.Podcast);

Lista.Add(reproducible1);
Lista.Add(reproducible2);
Lista.Add(reproducible3);

Console.WriteLine($"Duracion total: {Lista.DameDuracionTotal()}, Numero de reproducibles: {Lista.Count()}, Coste de Anuncios {Lista.CosteAnuncios()}");