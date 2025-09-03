// Aqui eu criei a interface igual ao que está no backend
export interface IBestiarioRecord {
  id: number;
  nome: string;
  descricao: string | null;
  hp: number;
  nivel: number;
  nivelPerigo: NivelPerigo;
  raridade: Raridade;
  dano: number;
  defesa: number;
  dtRegistro: string | null;
  tipo: Tipo;
}

export enum NivelPerigo {
  NENHUM = 0,
  BAIXO = 1,
  MEDIO = 2,
  ALTO = 3,
  EXTREMO = 4,
  FUJA = 5
}

export enum Raridade {
  COMUM = 1,
  INCOMUM = 2,
  RARO = 3,
  LENDARIO = 4,
  ICONICO = 5
}

export enum Tipo {
  HUMANO = 1,
  MORTO_VIVO = 2,
  SELVAGEM = 3,
  GIGANTE = 4,
  ABERRACAO = 5,
  INSETO = 6,
  CONSTRUTO = 7
}