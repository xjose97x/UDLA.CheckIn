/**
 * UDLA CheckIn
 * Web API para registro de tiempos para docentes
 *
 * OpenAPI spec version: v1
 * Contact: jose.escudero@udla.edu.ec
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
/* tslint:disable:no-unused-variable member-ordering */

import { Inject, Injectable, Optional }                      from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams,
         HttpResponse, HttpEvent }                           from '@angular/common/http';
import { CustomHttpUrlEncodingCodec }                        from '../encoder';

import { Observable }                                        from 'rxjs/Observable';

import { EmployeeDto } from '../model/employeeDto';
import { FacultyDto } from '../model/facultyDto';

import { BASE_PATH, COLLECTION_FORMATS }                     from '../variables';
import { Configuration }                                     from '../configuration';
import { environment } from '../../../../../environments/environment';


@Injectable()
export class FacultyService {

    protected basePath = environment.apiUrl;
    public defaultHeaders = new HttpHeaders();
    public configuration = new Configuration();

    constructor(protected httpClient: HttpClient, @Optional()@Inject(BASE_PATH) basePath: string, @Optional() configuration: Configuration) {
        if (basePath) {
            this.basePath = basePath;
        }
        if (configuration) {
            this.configuration = configuration;
            this.basePath = basePath || configuration.basePath || this.basePath;
        }
    }

    /**
     * @param consumes string[] mime-types
     * @return true: consumes contains 'multipart/form-data', false: otherwise
     */
    private canConsumeForm(consumes: string[]): boolean {
        const form = 'multipart/form-data';
        for (let consume of consumes) {
            if (form === consume) {
                return true;
            }
        }
        return false;
    }


    /**
     * 
     * 
     * @param facultyId 
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public apiFacultyByFacultyIdEmployeesGet(facultyId: number, observe?: 'body', reportProgress?: boolean): Observable<Array<EmployeeDto>>;
    public apiFacultyByFacultyIdEmployeesGet(facultyId: number, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<Array<EmployeeDto>>>;
    public apiFacultyByFacultyIdEmployeesGet(facultyId: number, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<Array<EmployeeDto>>>;
    public apiFacultyByFacultyIdEmployeesGet(facultyId: number, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {
        if (facultyId === null || facultyId === undefined) {
            throw new Error('Required parameter facultyId was null or undefined when calling apiFacultyByFacultyIdEmployeesGet.');
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            'text/plain',
            'application/json',
            'text/json',
            'application/xml',
            'text/xml'
        ];
        let httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set("Accept", httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        let consumes: string[] = [
        ];

        return this.httpClient.get<Array<EmployeeDto>>(`${this.basePath}/api/Faculty/${encodeURIComponent(String(facultyId))}/employees`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * 
     * 
     * @param id 
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public apiFacultyByIdDelete(id: number, observe?: 'body', reportProgress?: boolean): Observable<any>;
    public apiFacultyByIdDelete(id: number, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<any>>;
    public apiFacultyByIdDelete(id: number, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<any>>;
    public apiFacultyByIdDelete(id: number, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {
        if (id === null || id === undefined) {
            throw new Error('Required parameter id was null or undefined when calling apiFacultyByIdDelete.');
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
        ];
        let httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set("Accept", httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        let consumes: string[] = [
        ];

        return this.httpClient.delete<any>(`${this.basePath}/api/Faculty/${encodeURIComponent(String(id))}`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * 
     * 
     * @param id 
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public apiFacultyByIdGet(id: number, observe?: 'body', reportProgress?: boolean): Observable<FacultyDto>;
    public apiFacultyByIdGet(id: number, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<FacultyDto>>;
    public apiFacultyByIdGet(id: number, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<FacultyDto>>;
    public apiFacultyByIdGet(id: number, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {
        if (id === null || id === undefined) {
            throw new Error('Required parameter id was null or undefined when calling apiFacultyByIdGet.');
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            'text/plain',
            'application/json',
            'text/json',
            'application/xml',
            'text/xml'
        ];
        let httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set("Accept", httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        let consumes: string[] = [
        ];

        return this.httpClient.get<FacultyDto>(`${this.basePath}/api/Faculty/${encodeURIComponent(String(id))}`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * 
     * 
     * @param offset 
     * @param limit 
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public apiFacultyGet(offset?: number, limit?: number, observe?: 'body', reportProgress?: boolean): Observable<Array<FacultyDto>>;
    public apiFacultyGet(offset?: number, limit?: number, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<Array<FacultyDto>>>;
    public apiFacultyGet(offset?: number, limit?: number, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<Array<FacultyDto>>>;
    public apiFacultyGet(offset?: number, limit?: number, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (offset !== undefined) {
            queryParameters = queryParameters.set('Offset', <any>offset);
        }
        if (limit !== undefined) {
            queryParameters = queryParameters.set('Limit', <any>limit);
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            'text/plain',
            'application/json',
            'text/json',
            'application/xml',
            'text/xml'
        ];
        let httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set("Accept", httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        let consumes: string[] = [
        ];

        return this.httpClient.get<Array<FacultyDto>>(`${this.basePath}/api/Faculty`,
            {
                params: queryParameters,
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * 
     * 
     * @param facultyDto 
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public apiFacultyPost(facultyDto?: FacultyDto, observe?: 'body', reportProgress?: boolean): Observable<FacultyDto>;
    public apiFacultyPost(facultyDto?: FacultyDto, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<FacultyDto>>;
    public apiFacultyPost(facultyDto?: FacultyDto, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<FacultyDto>>;
    public apiFacultyPost(facultyDto?: FacultyDto, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            'text/plain',
            'application/json',
            'text/json',
            'application/xml',
            'text/xml'
        ];
        let httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set("Accept", httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        let consumes: string[] = [
            'application/json-patch+json',
            'application/json',
            'text/json',
            'application/_*+json',
            'application/xml',
            'text/xml',
            'application/_*+xml'
        ];
        let httpContentTypeSelected:string | undefined = this.configuration.selectHeaderContentType(consumes);
        if (httpContentTypeSelected != undefined) {
            headers = headers.set("Content-Type", httpContentTypeSelected);
        }

        return this.httpClient.post<FacultyDto>(`${this.basePath}/api/Faculty`,
            facultyDto,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * 
     * 
     * @param facultyDto 
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public apiFacultyPut(facultyDto?: FacultyDto, observe?: 'body', reportProgress?: boolean): Observable<any>;
    public apiFacultyPut(facultyDto?: FacultyDto, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<any>>;
    public apiFacultyPut(facultyDto?: FacultyDto, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<any>>;
    public apiFacultyPut(facultyDto?: FacultyDto, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
        ];
        let httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set("Accept", httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        let consumes: string[] = [
            'application/json-patch+json',
            'application/json',
            'text/json',
            'application/_*+json',
            'application/xml',
            'text/xml',
            'application/_*+xml'
        ];
        let httpContentTypeSelected:string | undefined = this.configuration.selectHeaderContentType(consumes);
        if (httpContentTypeSelected != undefined) {
            headers = headers.set("Content-Type", httpContentTypeSelected);
        }

        return this.httpClient.put<any>(`${this.basePath}/api/Faculty`,
            facultyDto,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

}
