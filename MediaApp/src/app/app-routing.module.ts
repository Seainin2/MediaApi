import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full'
  },
  {
    path: 'login',
    loadChildren: () => import('./pages/login/login.module').then( m => m.LoginPageModule),
  },
  {
    path: 'signup',
    loadChildren: () => import('./pages/signup/signup.module').then( m => m.SignupPageModule)
  },
  {
    path: 'sidenav',
    loadChildren: () => import('./pages/sidenav/sidenav.module').then( m => m.SidenavPageModule)
  },
  {
    path: 'movie',
    loadChildren: () => import('./pages/details/movie/movie.module').then( m => m.MoviePageModule)
  },
  {
    path: 'games',
    loadChildren: () => import('./pages/details/games/games.module').then( m => m.GamesPageModule)
  },

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
