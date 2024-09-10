namespace Desnz.Mees.DataTool.Data;

public class Class1
{
    /* get new postgres docker - done
     * try docker compose - done
     * gitignore for .net - done
     * create db - done
     *
     * give up on aws for now. can't create lambdas which are needed for data import to rds and db api
     * filter abp by commercial only - smaller files, xref - only with uarns.
     * recreate db and load in tables.
     * web app, api, db, domain proj. all running locally
     * 
     * set up types, 
     * dbcontext
     * figure out how to deploy to aws 
     * can write from parquet to postgres with python script in lambda, need to get it all on aws.
     */
}

public class DataSettings
{
    public string DbConnectionString { get; set; }
}