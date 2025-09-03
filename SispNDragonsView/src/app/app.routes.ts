import { Routes } from '@angular/router';
import { FormularioComponent } from './bestiario/formulario/formulario.component';
import { ListagemComponent } from './bestiario/listagem/listagem.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [

  // Informa que quando a rota estiver vazia (nesse caso 'http://localhost:4200') ele deve renderizar no lugar do <router-outlet> o componente de HomeComponent
  { path: '', component: HomeComponent, title: 'Início' },

  // Informa que quando a rota for 'http://localhost:4200/bestiario' ele deve renderizar no lugar do <router-outlet> o componente de ListagemComponent
  { path: 'bestiario', component: ListagemComponent, title: 'Lista de Bestiário' },

  // Informa que quando a rota for 'http://localhost:4200/bestiario/adicionar' ele deve renderizar no lugar do <router-outlet> o componente de FormularioComponent
  { path: 'bestiario/adicionar', component: FormularioComponent, title: 'Adicionar Bestiário' },

  // Informa que quando a rota for 'http://localhost:4200/bestiario/editar/:id' ele deve renderizar no lugar do <router-outlet> o componente de FormularioComponent
  // O parâmetro ':id' é utilizado para identificar qual bestiário deve ser editado, ele será substituído na execução por algum valor qualquer, por exemplo: 'http://localhost:4200/bestiario/editar/6'
  { path: 'bestiario/editar/:id', component: FormularioComponent, title: 'Editar Bestiário' },

];
