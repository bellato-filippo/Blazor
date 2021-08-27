
using Microsoft.AspNetCore.Components;

namespace event_manager_wasm.Client.Components;
public partial class ListaEventi
{
    [Parameter]
    public string Titolo { get; set; } = "Lista Eventi";
    
    [Parameter]
    public List<Models.ElementoListaEventi>? ListaElementi {  get; set; }

    [Parameter]
    public EventCallback<Models.ElementoListaEventi> OnElimina {  get; set; }

    public void EliminaElemento(Models.ElementoListaEventi evento)
    {
        this.ListaElementi.Remove(evento);
    }

    [Parameter]
    public EventCallback OnCrea {  get; set; }

    [Parameter]
    public EventCallback<Models.ElementoListaEventi> OnModifica {  get; set; }
}
