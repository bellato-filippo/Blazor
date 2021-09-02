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

System.InvalidOperationException: 'Client 'event-manager-wasm.Client' not found.'
Soluzione: se il nome del progetto contiene alcuni simboli, tra cui "-" vs fa casino e bisgna cambiare manualmente il nome del progetto all'interno del file project.Server.appsetting.json

the name does not exist in the current context
Soluzuione: probabilmente un problema di scoping. Assicurarsi che tutte le variabili coinvolte siano visibili e che i nomi delle classi siano corretti

Problemi con OnSalva, EventCallback e InvokeAsync()
Soluzione: il metodo OnSalva NON può essere nullo. Inserendo l'operatore ? il metodo da errore

EditForm requires either a Model parameter or an EditContext parameter
Soluzione: probabilmente un problema di inizializzazione dell'oggetto. Quando si usa il componente, se il Model è un parametro, bisogna assicurarsi che esso sia inizializzato con new
