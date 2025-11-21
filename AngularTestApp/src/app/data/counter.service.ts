import { Injectable, Signal } from '@angular/core';
import { Counter } from '../models/counter.model';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom, } from 'rxjs';

@Injectable({
    providedIn: 'root',
})

export class CounterService {

    private api = 'http://localhost:8080/Counter';

    constructor(private http: HttpClient) { }


    async getCounter(): Promise<Counter> {
        const result = await firstValueFrom(this.http.get<Counter>(`${this.api}/New`))
        if (!result) {
            console.error("shit");
            throw new Error("No counter returned");
        }
        return result;
    }

    async addOneToCounter(counter: Counter): Promise<Counter> {
        const result = await firstValueFrom(this.http.patch<Counter>(`${this.api}/Value/up`, counter))
        if (!result) {
            console.error("shit");
            throw new Error("No counter returned");
        }
        return result;
    }
        
    async removeOneFromCounter(counter: Counter): Promise<Counter> {
        const result = await firstValueFrom(this.http.patch<Counter>(`${this.api}/Value/down`, counter))
        if (!result) {
            console.error("shit");
            throw new Error("No counter returned");
        }
        return result;
    }
}