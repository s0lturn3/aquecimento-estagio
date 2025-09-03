import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IBestiarioRecord } from '../models/bestiario.model';

@Injectable({
  providedIn: 'root'
})
export class BestiarioService {

  // #region Properties

  // Por boas práticas sempre temos umas variável de URL dentro dos services, esta é a URL da API até o ponto do controller (que no meu caso é '/api/bestiario'),
  // os endpoints específicos, se necessário são informados dentro de cada método de serviço
  private readonly apiURL: string = "https://localhost:7124/api/bestiario";

  // #endregion Properties


  // O HttpClient é um serviço do Angular que permite fazer requisições HTTP de forma mais facilitada e com mais controle do que usar Javascript puro
  // Ele é geralmente injetado no constructor ou por meio de inject() no arquivo de Service
  constructor( private _http: HttpClient ) { }


  // #region Services

  // Este método utiliza o HttpClient para fazer uma requisição GET e obter a lista de bestiários
  // O método .get() do HttpClient realiza uma operação de GET para uma API e a sua estrutura de parâmetros segue esta ordem:
  // String da URL e um objeto com parâmetros extras como os headers
  getBestiarioList(): Observable<IBestiarioRecord[]> {
    return this._http.get<IBestiarioRecord[]>(`${this.apiURL}`);
  }

  // Este método utiliza o HttpClient para fazer uma requisição GET e obter um bestiário pelo ID
  // O método .get() do HttpClient realiza uma operação de GET para uma API e a sua estrutura de parâmetros segue esta ordem:
  // String da URL e um objeto com parâmetros extras como os headers
  getBestiarioById(id: number): Observable<IBestiarioRecord> {
    return this._http.get<IBestiarioRecord>(`${this.apiURL}/${id}`);
  }

  // Este método utiliza o HttpClient para fazer uma requisição POST e criar um novo bestiário
  // O método .post() do HttpClient realiza uma operação de POST para uma API e a sua estrutura de parâmetros segue esta ordem:
  // String da URL, o objeto que será passado no Corpo da requisição e um objeto com parâmetros extras como os headers
  createBestiario(bestiario: IBestiarioRecord): Observable<IBestiarioRecord> {
    return this._http.post<IBestiarioRecord>(`${this.apiURL}`, bestiario);
  }

  // Este método utiliza o HttpClient para fazer uma requisição PUT e atualizar um bestiário existente
  // O método .put() do HttpClient realiza uma operação de PUT para uma API e a sua estrutura de parâmetros segue esta ordem:
  // String da URL, o objeto que será passado no Corpo da requisição e um objeto com parâmetros extras como os headers
  updateBestiario(bestiario: IBestiarioRecord): Observable<IBestiarioRecord> {
    return this._http.put<IBestiarioRecord>(`${this.apiURL}/${bestiario.id}`, bestiario);
  }

  // Este método utiliza o HttpClient para fazer uma requisição DELETE e remover um bestiário existente
  // O método .delete() do HttpClient realiza uma operação de DELETE para uma API e a sua estrutura de parâmetros segue uma ordem semelhante à de GET:
  // String da URL e um objeto com parâmetros extras como os headers
  deleteBestiario(id: number): Observable<void> {
    return this._http.delete<void>(`${this.apiURL}/${id}`);
  }

  // #endregion Services

}
