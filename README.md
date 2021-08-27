Problemi ricorrenti in Blazor wasm con vs 2022 preview

Il template di prova rimane fermo in "Authorizing..." e segnala "An unhandled error has occurred. Reload"
Soluzione: nella package manager console eseguire "update-database"

The specified deps.json [C:\Users\Filippo\source\repos\BlazorApp1\BlazorApp1\Client\bin\Debug\net6.0\BlazorApp1.Client.deps.json] does not exist
Soluzione:
1- Chiudere vs
2- eliminare le cartelle bin e obj del progetto
3- impostare il progetto.Server come startup project(forse non serve)
4- ricompilare la soluzione
5- assicurarsi che la package manager console stia operando nel progetto giusto
