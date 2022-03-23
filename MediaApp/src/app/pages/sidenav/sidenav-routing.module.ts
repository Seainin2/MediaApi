import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SidenavPage } from './sidenav.page';

const routes: Routes = [
  {
    path: 'nav',
    component: SidenavPage,
    children: [
      {
        path: 'media',
        loadChildren: () => import('../media/media.module').then(m => m.MediaPageModule)
      },
      {
        path: 'calender',
        loadChildren: () => import('../calender/calender.module').then(m => m.CalenderPageModule)
      },
      {
        path: 'forums',
        loadChildren: () => import('../forums/forums.module').then(m => m.ForumsPageModule)
      },
      {
        path: 'messages',
        loadChildren: () => import('../messages/messages.module').then( m => m.MessagesPageModule)
      },
      {
        path: 'profile',
        loadChildren: () => import('../profile/profile.module').then(m => m.ProfilePageModule)
      },
      {
        path: '',
        redirectTo: '/nav/media',
        pathMatch: 'full'
      }
    ]
  },
  {
    path: '',
    redirectTo: 'nav/media',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class SidenavPageRoutingModule {}
