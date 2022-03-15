import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SidenavPage } from './sidenav.page';

const routes: Routes = [
  {
    path: 'sidenav',
    component: SidenavPage,
    children: [
      {
        path: 'media-tabs',
        loadChildren: () => import('../medias/media-tabs/media-tabs.module').then(m => m.MediaTabsPageModule)
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
        path: 'friends',
        loadChildren: () => import('../friends/friends.module').then(m => m.FriendsPageModule)
      },
      {
        path: 'profile',
        loadChildren: () => import('../profile/profile.module').then(m => m.ProfilePageModule)
      },
    ]
  },
  {
    path: '',
    redirectTo: 'sidenav/calender',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class SidenavPageRoutingModule {}
