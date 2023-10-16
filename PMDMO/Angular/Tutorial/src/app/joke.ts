export class Joke {

    private broma: string;
    private respuestaBroma :string;
    private oculto :boolean;
    private id :number ;
    static id_ : number = 0;

    constructor(broma :string,respuestaBroma :string){

        this.broma = broma;
        this.respuestaBroma = respuestaBroma;
        this.oculto = true;
        Joke.id_++;
        this.id = Joke.id_;
    }

    
    public getBroma()
    {
        return this.broma;
    } 
    public setBroma(broma:string)
    {
        this.broma = broma;
    }


    public getRespuestaBroma()
    {
        return this.respuestaBroma;
    } 
    public setRespuestaBroma(respuestaBroma:string)
    {
        this.respuestaBroma = respuestaBroma;
    }
    

    public getOculto()
    {
        return this.oculto;
    } 
    
    public setOculto(oculto:boolean)
    {
        this.oculto = oculto;
    }

    
    ocultar() {

        this.oculto = !this.oculto;

        }

}
