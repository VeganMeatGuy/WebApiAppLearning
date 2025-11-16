import { patchState, signalStore, withMethods, withState } from '@ngrx/signals';
import { Counter } from '../models/counter.model';

type AppState = {
	counter: Counter | undefined;
    test123: string;
};

const initialState: AppState = {
	counter: new Counter(),
    test123: "moin du sack"
};

export const AppStore = signalStore(
	{ providedIn: 'root' },
	withState(initialState),
	withMethods(
		(
			store,
		) => ({
			async init(): Promise<void> {
                patchState(store, {test123: "oder so"});
			},
			addOne(counter3: Counter | undefined): void {
                if (counter3 === undefined)
                {}
                else 
                {
                    counter3.value = counter3.value + 1;
				    patchState(store, {counter: counter3, test123: "geht"});
                }
				}
		})
	)
);