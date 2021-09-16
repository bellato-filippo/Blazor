Problemi ricorrenti in Blazor wasm con vs 2022 preview

Il template di prova rimane fermo in "Authorizing..." e segnala "An unhandled error has occurred. Reload"
Soluzione: nella package manager console eseguire "update-database"

The specified deps.json [C:\Users\Filippo\source\repos\BlazorApp1\BlazorApp1\Client\bin\Debug\net6.0\BlazorApp1.Client.deps.json] does not exist
Soluzione:
1- Chiudere vs
2- eliminare le cartelle bin e obj del progetto
3- impostare il progetto.Server come startup project(forse è l'unico passaggio necessario)
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

Unhandled exception rendering component: Cannot provide a value for property 'Syncfusion Service'
Soluzione: il builder.Services.AddSyncfusionBlazor(); va aggiunto in Project.Client.Program.cs e non in Project.Server.Program.cs

Cannot implicitly convert type 'void' to 'Object'
Soluzione: quando chiamo un metodo sul componente .razor con la sintassi @metodo(); il component si aspetta di mostrare a video qualcosa, ma se il metodo è void non c'è niente da mostrare. Per farlo basta inserire il metodo desiderato all'interno di un blocco @{}

Name does not exist in the current context
Soluzione: probabilmente il motivo è che all'interno di un componente(la parte c#) NON può esserci altro che la dichiarazione e inizializzazione di una variabile. Tutto il resto delle operazioni vanno create all'interno di un metodo che poi può essere tranquillamente chiamato.

Il CSS non si aggiorna
Soluzione: cancellare la cache di chrome con shift+ctrl+canc > cancella dati
