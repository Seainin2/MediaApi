import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MediaTabsPage } from './media-tabs.page';

const routes: Routes = [
  {
    path: 'media-tabs',
    component: MediaTabsPage,
    children: [
      {
        path: 'movies',
        children: [
          {
            path: '',
            loadChildren: () => import('../movies/movies.module').then( m => m.MoviesPageModule)
          }
        ]
      },
      {
        path: 'books',
        children: [
          {
            path: '',
            loadChildren: () => import('../books/books.module').then( m => m.BooksPageModule)
          }
        ]
      },
      {
        path: 'games',
        children: [
          {
            path: '',
            loadChildren: () => import('../games/games.module').then( m => m.GamesPageModule)
          }
        ]
      },
      {
        path: '',
        redirectTo: '/movies',
        pathMatch: 'full'
      }
    ]
  },
  {
    path: '',
    redirectTo: 'media-tabs/movies',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class MediaTabsPageRoutingModule {}
