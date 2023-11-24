import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AppDataService {
  private apiUrl = 'https://localhost:7179/Cd';

  constructor(private http: HttpClient) { }

  Get(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }

  Post(dados: string): Observable<any> {
    return this.http.post<any>(this.apiUrl, dados);
  }
}
