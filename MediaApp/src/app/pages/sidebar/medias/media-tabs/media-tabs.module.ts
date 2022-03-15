import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { MediaTabsPageRoutingModule } from './media-tabs-routing.module';

import { MediaTabsPage } from './media-tabs.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    MediaTabsPageRoutingModule
  ],
  declarations: [MediaTabsPage]
})
export class MediaTabsPageModule {}
