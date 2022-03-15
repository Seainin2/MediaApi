export interface All {
}
export interface Movies{
  movies: Movie[]
}

export interface Movie {
  mediaId: string;
  seriesId: string;
  creatingPropertyId: string;
  title: string;
  releaseDate: string;
  description: string;
  numberofTimesSearched: number;
  length: number;
}
