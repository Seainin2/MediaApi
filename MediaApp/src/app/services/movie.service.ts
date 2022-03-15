import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Movies } from '../Interfaces/all';
import { AlertController, LoadingController, Platform } from '@ionic/angular';
import { finalize, map } from 'rxjs/operators';
import { HTTP } from '@ionic-native/http/ngx';


@Injectable({
  providedIn: 'root'
})
export class MovieService {
  url = 'http://localhost:5000/api/movies';
  apiKey = "";

  constructor(private http: HttpClient, private nativeHttp: HTTP,private plt: Platform, private loadingCtrl: LoadingController) { }

  searchData(): Observable<any>{
      return this.http.get(`${this.url}`).pipe(map(results => results[0]));

  }

  getDetails(id){
    return this.http.get(`${this.url}/${id}`);
  }


}
