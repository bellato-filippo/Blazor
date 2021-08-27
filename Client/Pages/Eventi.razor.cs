namespace event_manager_wasm.Client.Pages;
public partial class Eventi
{

    public Models.Evento EventoCorrente {  get; set; }

    public List<Models.ElementoListaEventi> ListaEventi { get; set; }
        = new List<Models.ElementoListaEventi>
        {
            new Models.ElementoListaEventi() {Id = 1, Nome = "DevDay", Localita = "Benevento", Data = new DateTime(2020, 2, 8)},
            new Models.ElementoListaEventi() {Id = 2, Nome = "DotNetSide", Localita = "Bari", Data = new DateTime(2020, 2, 21)}
        };

    public void CreaEvento()
    {
        this.EventoCorrente = new Models.Evento();
    }

    public void ModificaEvento(Models.ElementoListaEventi evento)
    {
        this.EventoCorrente = new Models.Evento()
        {
            Id = evento.Id,
            Nome = evento.Nome,
            Localita = evento.Localita,
            Data = evento.Data
        };
    }

    public void SalvaEvento(Models.Evento evento)
    {
        if(evento.Id == 0)
        {
            this.ListaEventi.Add(new Models.ElementoListaEventi()
            {
                Id = this.ListaEventi.Count() > 0 ? this.ListaEventi.Max(x => x.Id) + 1 : 1,
                Nome = evento.Nome,
                Localita = evento.Localita,
                Data = evento.Data
            });
        }
        else
        {
            var eventoDaModificare = this.ListaEventi.Single(x => x.Id == evento.Id);
            eventoDaModificare.Nome = evento.Nome;
            eventoDaModificare.Localita = evento.Localita;
            eventoDaModificare.Data = evento.Data;
        }
        this.EventoCorrente = null;
    }

    public void AnnullaOperazione()
    {
        this.EventoCorrente = null;
    }

    public void EliminaEvento(Models.ElementoListaEventi evento)
    {
        this.ListaEventi.Remove(evento);
    }
}
